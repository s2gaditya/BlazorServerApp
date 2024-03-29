namespace BlazorServerApp.Data
{
    public class User
    {
        public int Id { get; set; }
        
		public string FirstName { get; set; }
		
		public string LastName { get; set; }
		
		public string Address { get; set; }                

        public string? Area { get; set; }

        public string? PinCode { get; set; }

        public string? Test { get; set; }
    }
}
