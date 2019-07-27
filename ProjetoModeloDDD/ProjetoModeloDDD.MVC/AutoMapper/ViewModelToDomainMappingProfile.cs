using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModel;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produtos, ProdutoViewModel>();
            CreateMap<Agenda, AgendaViewModel>();
            CreateMap<Atendimento, AtendimentoViewModel>();
            CreateMap<Colaboradores, ColaboradorViewModel>();
            CreateMap<Fornecedores, FornecedorViewModel>();
            CreateMap<Horarios, HorariosViewModel>();
            CreateMap<Insumos, InsumoViewModel>();
            CreateMap<Itens, ItensViewModel>();
            CreateMap<NFs, NfViewModel>();
            CreateMap<Servicos, ServicoViewModel>();
            CreateMap<Vendas, VendaViewModel>();
        }
    }


}