using GofPatternsFun.Structural.Facade.SubSystem;

namespace GofPatternsFun.Structural.Facade
{
    /// <summary>
    /// Provides a general interface for accessing set of another objects
    /// Makes system easier to use
    /// Need to use when we need somehow interact between classes and don't want to make dependencies
    /// </summary>
    class SkiResortFacade
    {
        BookHotelSystem hotelSystem = new BookHotelSystem();
        SkiPassSystem skiPass = new SkiPassSystem();

        public int BookSkiTour(int days, int roomQuality)
        {
            int roomPrice = hotelSystem.BookRoom(roomQuality);
            int ticketPrice = skiPass.BuyTicket(days);
            return roomPrice*days + ticketPrice;
        }
    }
}
