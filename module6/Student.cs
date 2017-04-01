namespace module6 {
    public class Student : Person {
        public static int students = 0;
        public string City {get; set;}
        public void TakeTest() {
            
        }
        public Student() {
            students++;
        }
    }
}
