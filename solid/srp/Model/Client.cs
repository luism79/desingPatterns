namespace srp.Model
{
    internal class Client
    {
        private string ConvertDateOfBirthToString()
        {
            if (DateOfBirth == DateOnly.MinValue)
                return "";

            return DateOfBirth.ToString("dd/MM/yyyy");
        }
        public Client(int id) 
        {
            ID = id;
        }
        public int ID { get; }
        public string Name { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        public void Print()
        {
            Console.Write("==================================================\n" +
                          "                     Client\n" +
                          "--------------------------------------------------\n" +
                          $"  ID............: {ID}\n" +
                          $"  Name..........: {Name}\n" +
                          $"  Date of Birth.: {ConvertDateOfBirthToString()}\n" +
                          $"  E-mail........: {Email}\n" +
                          "--------------------------------------------------");
        }
    }   
}
