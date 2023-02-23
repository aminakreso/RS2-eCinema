using eCinema.Model.Dtos;

namespace eCinema.Model.Requests;

public class ReservationUpsertRequest
{
    public Guid PojectionId { get; set; }
    
    public List<Guid>? SeatsId { get; set; }

}