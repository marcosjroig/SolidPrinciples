using System;

namespace SolidPrinciplesPrototype.LiskovSubstitutionPrinciple
{
    public interface IDataRepository
    {
        void Persist(object _object);
        object Read(decimal id);
    }

    public class CustomerRepository : IDataRepository
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

    public class HistoricStockPriceRepository : IDataRepository
    {
        public void Persist(object _object)
        {
            throw new Exception("Data is read only!");
        }

        public object Read(decimal id)
        {
            // Read from the database
            return null;
        }
    }

    /// <summary>
    /// We are forced to change the UiController class because an specific implementation of the IDataRepository
    /// </summary>
    public class UiController // Used to iteract with the back-end from the IO layer
    {
        private readonly IDataRepository _dataRepository;

        public UiController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void Persist(object _object)
        {
            // HistoricStockPriceRepository cannot persist data so we use this if
            if (_dataRepository.GetType() != typeof(HistoricStockPriceRepository))
            {
                _dataRepository.Persist(_object);
            }
        }

        public object Retrieve(decimal id)
        {
            // Read from the database
            return _dataRepository.Read(id);
        }
    }
}
