using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produtos>();
            CreateMap<AgendaViewModel, Agenda>();
            CreateMap<AtendimentoViewModel, Atendimento>();
            CreateMap<ColaboradorViewModel, Colaboradores>();
            CreateMap<FornecedorViewModel, Fornecedores>();
            CreateMap<HorariosViewModel, Horarios>();
            CreateMap<InsumoViewModel, Insumos>();
            CreateMap<ItensViewModel, Itens>();
            CreateMap<NfViewModel, NFs>();
            CreateMap<VendaViewModel, Vendas>();
        }
    }
}