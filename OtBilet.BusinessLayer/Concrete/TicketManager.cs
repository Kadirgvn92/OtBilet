﻿using OtBilet.BusinessLayer.Abstract;
using OtBilet.DAL.Abstract;
using OtBilet.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtBilet.BusinessLayer.Concrete;
public class TicketManager : ITicketService
{
	private readonly ITicketDal _ticketDal;

	public TicketManager(ITicketDal ticketDal)
	{
		_ticketDal = ticketDal;
	}

    public void TAdd(Ticket entity)
	{
		_ticketDal.Add(entity);
	}

	public void TDelete(Ticket entity)
	{
		_ticketDal.Delete(entity);
	}

	public List<Ticket> TGetAll()
	{
		return _ticketDal.GetAll();
	}

	public Ticket TGetByID(int id)
	{
		return _ticketDal.GetByID(id);
	}

	public void TUpdate(Ticket entity)
	{
		_ticketDal.Update(entity);
	}

    public Ticket GetTicketByDestinationID(int id)
    {
		return _ticketDal.GetTicketByDestinationID(id);
    }
}
