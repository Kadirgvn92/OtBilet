using FluentValidation;
using OtBilet.DTOLayer.SeatDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.ValidationRules;
public class TicketValidator : AbstractValidator<SeatNumberDTO>
{
    public TicketValidator()
    {
        RuleFor(x => x.SeatNumber).NotEmpty().WithMessage("Lütfen bir koltuk numarası seçiniz");
    }
}
