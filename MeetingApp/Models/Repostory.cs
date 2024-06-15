namespace MeetingApp.Models
{
    public static class Repostory
    {
        private static List<Userİnfo> _users = new();
        static Repostory()
        {
            _users.Add(new Userİnfo() { Id=1,Name="serdal",Eposta="serda@gmail.com",Phone=1111,wiilattend=true});
            _users.Add(new Userİnfo() { Id = 2, Name = "ali", Eposta = "ali@gmail.com", Phone = 2222, wiilattend = false });
            _users.Add(new Userİnfo() { Id = 3, Name = "sezer", Eposta = "sezer@gmail.com", Phone = 3333, wiilattend = true });



        }
        public static List<Userİnfo>users { get { return _users; } }
        public static void CreateUser(Userİnfo user) {
            _users.Add(user);
            user.Id = users.Count + 1;
        }

    }
}
