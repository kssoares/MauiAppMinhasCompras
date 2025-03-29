using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        private double? _quantidade;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set {
                if (value == null) {
                    throw new Exception("Por favor, preencha o campo");
                }
                _descricao = value;
            }
        }
        public double? Quantidade {
            get => _quantidade;
            set { 
                if(value <= 0) 
                    throw new Exception("Por favor, preencha o campo"); 
                _quantidade = value; 
            }
        }
        public double Preco { get; set; }

        public double Total => (Quantidade ?? 0) * Preco;
    }
}