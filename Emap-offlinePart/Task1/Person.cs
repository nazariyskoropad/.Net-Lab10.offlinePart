namespace Epam.Task1Part1
{
    public struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string isOlderOrYounger(int n)
        {
            if (this.Age > n)
                return $"{this.Name} {this.Surname} older than {n}";
            else if (this.Age < n)
                return $"{this.Name} {this.Surname} younger than {n}";
            else
                return $"{this.Name} {this.Surname} is {n} years old";
        }    
    }
}
