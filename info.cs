namespace curse01
{
    public class info
    {
        
        public string Nome { get; set; }
        public string Email { get; set; }

                

        public info(string nome, string email)
        {
            Nome = nome;
            Email = email;
           

        }

        public override string ToString()
        {
            return  Nome +" , "  + Email;


            
        }





    }
}