namespace SHC.UROCare.UI
{
    public interface IPresenterBase<IView, IPersistable>
    {
        /// <summary>
        /// Initializes view from the database 
        /// </summary>
        void InitViewFromModel();

        /// <summary>
        /// Saves model object to the database.
        /// </summary>
        void Save();

        /// <summary>
        /// Gets the model object of the presenter.
        /// </summary>
        IPersistable ModelObject { get; }

        /// <summary>
        /// Gets view of the presenter.
        /// </summary>
        IView View { get; }
    }
}