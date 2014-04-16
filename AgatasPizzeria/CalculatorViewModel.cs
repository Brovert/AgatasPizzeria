namespace AgatasPizzeria {
    public class CalculatorViewModel {
        public int SomeNumber  { get; set; }
        public int Result { get; set; }

        public void RunCalculation() {

            if (SomeNumber > 100) {
                Result = 99;
            } else {
                Result = -1;
            }

        }
    }
}
