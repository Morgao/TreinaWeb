namespace RH
{
    public class Funcionarios
    {
        public string Nome;
        private string cpf;

        public string CPF
        {
            get
            {
                return cpf.Replace(".","").Replace("-","");
            }
            set
            {
                if(value.Length == 0)
                return;
                cpf = value;
            }
        }

        public Funcionarios(string nome, string _cpf)
        {
            Nome = nome;
            cpf = _cpf;
        }

      
    }
}