using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Model.Constants;
using eCinema.Services.Database;
using eCinema.Services.ProjectionStateMachine;

namespace eCinema.Services.Services
{
    public class ProjectionService : BaseCRUDService<ProjectionDto, Projection, ProjectionSearchObject, ProjectionUpsertRequest, ProjectionUpsertRequest>,
        IProjectionService
    {
        private readonly BaseProjectionState _baseState;
        public ProjectionService(CinemaContext cinemaContext, IMapper mapper, BaseProjectionState baseState) : base(cinemaContext, mapper)
        {
            _baseState = baseState;
        }

        public override async Task<ProjectionDto> Insert(ProjectionUpsertRequest insert)
        {
            var state = _baseState.CreateState(StateMachineConstants.InitialState);
           
            return await state.Insert(insert);
        }
        
        public override async Task<ProjectionDto> Update(Guid id, ProjectionUpsertRequest update)
        {
            var projection = await _cinemaContext.Projections.FindAsync(id);
            
            var state = _baseState.CreateState(projection?.ProjectionStatus ?? throw new InvalidOperationException());
            state.CurrentEntity = projection;

            await state.Update(update);

            return await GetById(id);
        }

        public override async Task<ProjectionDto> Delete(Guid id)
        {
            var projection = await _cinemaContext.Projections.FindAsync(id);
            
            var state = _baseState.CreateState(projection?.ProjectionStatus ?? throw new InvalidOperationException());
            state.CurrentEntity = projection;

            await state.Delete();

            return await GetById(id);
        }

        public async Task<ProjectionDto> Activate(Guid id)
        {
            var projection = await _cinemaContext.Projections.FindAsync(id);
            
            var state = _baseState.CreateState(projection?.ProjectionStatus ?? throw new InvalidOperationException());
            state.CurrentEntity = projection;

            await state.Activate();

            return await GetById(id);
        }
        
        public async Task<ProjectionDto> Hide(Guid id)
        {
            var projection = await _cinemaContext.Projections.FindAsync(id);

            var state = _baseState.CreateState(projection?.ProjectionStatus ?? throw new InvalidOperationException());
            state.CurrentEntity = projection;

            await state.Hide();

            return await GetById(id);
        }

        
        public async Task<List<string>> AllowedActions(Guid id)
        {
            var projection = await GetById(id);
            var state = _baseState.CreateState(projection.ProjectionStatus ?? throw new InvalidOperationException());

            return state.AllowedActions();
        }
        
        public override IQueryable<Projection> AddFilter(IQueryable<Projection> query, ProjectionSearchObject search)
        {
            var filteredQuery = query;

            if(!string.IsNullOrWhiteSpace(search.ProjectionStatus))
                filteredQuery = filteredQuery.Where(x => x.ProjectionStatus!.ToLower().Contains(search.ProjectionStatus.ToLower()));
            
            if(search.DateTime is not null)
                filteredQuery = filteredQuery.Where(x => x.DateTime!.Value == search.DateTime.Value);


            return filteredQuery;

        }
    }
}
