namespace module5 {
    public class Student {
        public static int students = 0;
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string City {get; set;}
        public Student() {
            students++;
        }
    }
}
