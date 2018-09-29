[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoModeloDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoModeloDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoModeloDDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Application.Interface;
    using Application;
    using Domain.Interfaces.Servicos;
    using Domain.Services;
    using Infra.Data.Repositories;
    using Domain.Interfaces;
    using Application.Services;
    using Domain.Interfaces.Repositorios;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<IAgendaAppService>().To<AgendaAppService>();
            kernel.Bind<IAtendimentoAppService>().To<AtendimentoAppService>();
            kernel.Bind<IColaboradorAppService>().To<ColaboradorAppService>();
            kernel.Bind<IFornecedorAppService>().To<FornecedorAppService>();
            kernel.Bind<IHorarioAppService>().To<HorarioAppService>();
            kernel.Bind<IInsumoAppService>().To<InsumoAppService>();
            kernel.Bind<IItemAppService>().To<ItemAppService>();
            kernel.Bind<INfAppService>().To<NfAppService>();
            kernel.Bind<IServicoAppService>().To<ServicoAppService>();
            kernel.Bind<IVendasAppService>().To<VendaAppService>();

            kernel.Bind(typeof(IServicesBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteServices>().To<ClienteService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IAgendaServices>().To<AgendaService>();
            kernel.Bind<IAtendimentoServices>().To<AtendimentoService>();
            kernel.Bind<IColaboradoresServices>().To<ColaboradorService>();
            kernel.Bind<IFornecedoresServices>().To<FornecedorService>();
            kernel.Bind<IHorariosServices>().To<HorarioService>();
            kernel.Bind<IInsumosServices>().To<InsumosService>();
            kernel.Bind<IItemService>().To<ItemService>();
            kernel.Bind<INfsServices>().To<NfsService>();
            kernel.Bind<IServicesServices>().To<ServicesService>();
            kernel.Bind<IVendasServices>().To<VendasService>();

            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<IClienteRepositorio>().To<ClienteRepositorio>();
            kernel.Bind<IProdutoRepositorio>().To<ProdutoRepositorio>();
            kernel.Bind<IAgendaRepositorio>().To<AgendaRepositorio>();
            kernel.Bind<IAtendimentoRepositorio>().To<AtendimentoRepositorio>();
            kernel.Bind<IColaboradorRepositorio>().To<ColaboradorRepositorio>();
            kernel.Bind<IFornecedorRepositorio>().To<FornecedorRepositorio>();
            kernel.Bind<IHorarioRepositorio>().To<HorarioRepositorio>();
            kernel.Bind<IInsumosRepositorio>().To<InsumoRepositorio>();
            kernel.Bind<IItemRepositorio>().To<ItemRepositorio>();
            kernel.Bind<INfsRepositorio>().To<NfRepositorio>();
            kernel.Bind<IServicesRepositorio>().To<ServicoRepositorio>();
            kernel.Bind<IVendasRepositorio>().To<VendasRepositorio>();

        }
    }
}
