namespace SolidPrinciplesPrototype.LiskovSubstitutionPrinciple
{
    public interface IDataReadRepository
    {
        object Read(decimal id);
    }

    public interface IDataWriteRepository
    {
        void Persist(object _object);
    }

    public class CustomerRepository2 : IDataReadRepository, IDataWriteRepository
    {
        public void Persist(object _object)
        {
            // Write to Database
        }

        public object Read(decimal id)
        {
            // Read from the database
            return null;
        }
    }

    public class HistoricStockPriceRepository2 : IDataReadRepository
    {
        public object Read(decimal id)
        {
            // Read from the database
            return null;
        }
    }

    public class UiController2 // Used to iteract with the back-end from the IO layer
    {
        private readonly IDataReadRepository _dataReadRepository;
        private readonly IDataWriteRepository _dataWriteRepository;

        public UiController2(IDataReadRepository dataReadRepository, IDataWriteRepository dataWriteRepository)
        {
            _dataReadRepository = dataReadRepository;
            _dataWriteRepository = dataWriteRepository;
        }

        public void Persist(object _object)
        {
            // HistoricStockPriceRepository cannot persist data so we use this if
            if (_dataWriteRepository != null)
            {
                _dataWriteRepository.Persist(_object);
            }
        }

        public object Retrieve(decimal id)
        {
            if (_dataReadRepository != null)
            {
                 // Read from the database
                return _dataReadRepository.Read(id);
            }

            return null;
        }
    }
}
