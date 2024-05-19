namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
         Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados): this ()
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        
        
        {
            if (Suite == null)
            
            if(hospedes.Count >Suite.Capacidade)
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *Implementado
            if (true)
            {
                Hospedes = hospedes;
            }
        
            else
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *Implementado
            {
                
                throw new Exception("Capacidade da suite é menor que o numero de hospedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTENTADO
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTADO
            
            decimal valor = DiasReservados*Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            
            if (DiasReservados>=10)
            {
                valor = valor*0.10m;
            }

            return valor;
        }
    }
}