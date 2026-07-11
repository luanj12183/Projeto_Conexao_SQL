using Projeto_Conexao_MYSQL;

namespace Projeto_Conexao_MYSQL.Models
{
    public class Produto 
    {

    public int Id {get; set; } 

    public string NomesProdutos {get; set; } = string.Empty;

    public int Estoques {get; set; }

    public double Precos {get; set; }
    }
} 