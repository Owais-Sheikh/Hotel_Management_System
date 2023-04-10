using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Hotel_System.Classes
{
    class Manager 
    {
        private Classes.Room r = new Classes.Room();
        private Classes.Reservation reserv = new Classes.Reservation();
        private Classes.Billing bill = new Classes.Billing();
        private Classes.Service service = new Classes.Service();
        private Classes.Customer customer = new Classes.Customer();
        public Manager() { }

        
    
        public void ManageGuests(Customer C, string choice)
        {
            if (choice == "Add Guest")
            {
                customer.addGuest(C.Id, C.Name, C.PhoneNo, C.Address);
            }
            else if (choice == "Delete Guest")
            {
                customer.deleteGuest(C.Id);
            }
            else if (choice == "Update Guest")
            {
                customer.updateGuest(C.Id, C.Name, C.PhoneNo, C.Address);
            }

        }
        public DataTable ShowGuest(Customer C, string choice)
        {
            DataTable dt = new DataTable();
            if (choice == "Search Guest")
            {
                return customer.searchGuest(C.Id);
            }
            else if (choice == "Show All Guest")
            {
                return customer.showGuest();
            }
            else
            {
                return dt;
            }
        }
        public void Managerooms(Room R,string choice)
        {
            if (choice == "Add Room")
            {
                r.addRoom(R.roomNumber, R.roomType, R.roomSize, R.dailyRent);
            }
            else if (choice == "Delete Room")
            {
                r.deleteRoom(R.roomNumber);
            }
            else if (choice == "Update Room")
            {
                r.updateRoom(R.roomNumber, R.roomType, R.roomSize, R.dailyRent);
            }
           
        }
        public DataTable ShowRoom(Room room,string choice)
        {
            DataTable dt = new DataTable();
            if (choice == "Search Room")
            {
                return r.searchRoom(room.roomNumber);
            }
            else if (choice == "Check Availability")
            {
                return r.checkAvailability(room.roomNumber);
            }
            else if(choice == "Show All Room")
            {
                return room.showRoom();
            }
            else
            {
                return dt;
            }
        }
        public void manageReservation(Reservation reservation, Customer c, Room r,string choice)
        {
            if (choice == "Add Reservation")
            {
                reserv.handleBooking(reservation.ReservatonId,r.roomNumber,c.Id,c.Name, reservation.CheckIn, reservation.CheckOut,reservation.NoofDays);
            }
            else if (choice == "Cancel Reservation")
            {
                reserv.cancelBooking(reservation.ReservatonId);
            }
            else if (choice == "Update Reservation")
            {
                reserv.updateBooking(reservation.ReservatonId, r.roomNumber, c.Id, c.Name, reservation.CheckIn, reservation.CheckOut,reservation.NoofDays);
            }
            
        }
        public void manageServices(Service sevice,string choice)
        {
            if (choice == "Add Service")
            {
                service.addService(sevice.serviceId,sevice.serviceType,sevice.servicePrice);
            }
            else if (choice == "Cancel Service")
            {
                service.deleteService(sevice.serviceId);
            }
            else if (choice == "Update Service")
            {
                service.updateService(sevice.serviceId, sevice.serviceType, sevice.servicePrice);
            }
        }
        public DataTable showServices(Service s, string choice)
        {
            DataTable dt = new DataTable();
            if (choice == "Search Service")
            {
                return service.searchService(s.serviceId);
            }
            else if (choice == "Show All Service")
            {
                return service.showService();
            }
            else
            {
                return dt;
            }
        }
        public DataTable showReservation(Reservation reservation,string choice)
        {
            DataTable dt = new DataTable();
            if (choice == "Search Reservation")
            {
                return reserv.searchReservation(reservation.ReservatonId);
            }
            else if(choice == "Show All Reservation")
            {
                return reserv.showReservation();
            }
            else
            {
                return dt;
            }
        }
        public void provideServices(Reservation reserv, string s)
        {
            service.provideService(s, reserv.ReservatonId);
        }
        public string payment(string choice)
        {
            if (choice == "Total Charges")
            {
                return bill.TotalBill();
            }
            else
            {
                return bill.payment(choice);
            }
        }
        internal Reservation Reservation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Customer Customer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Room Room
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Service Service
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal Billing Billing
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
    }
}
