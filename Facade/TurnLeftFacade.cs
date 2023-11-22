namespace Facade
{
    public class TurnLeftFacade
    {
        private Eyes eyes = new();
        private Legs legs = new();
        private Hands hands = new();

        public void TurnLeft()
        {
            Console.WriteLine("This is how you make a left turn:");

            hands.SignalLeft();
            eyes.LookOverLeftShoulder();
            legs.SlowDown();
            hands.TurnLeft();
        }
    }
}
