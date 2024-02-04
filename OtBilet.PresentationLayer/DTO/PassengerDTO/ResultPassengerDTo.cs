using OtBilet.EntityLayer;

namespace OtBilet.PresentationLayer.DTO.PassengerDTO;

public class ResultPassengerDTo
{
	public int PassengerID { get; set; }
	public string NationalCardNo { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public string PhoneNumber { get; set; }
	public bool Luggage { get; set; }
	public Gender Gender { get; set; }
}
