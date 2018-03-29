namespace BankOperations
{
    /// <summary>
    /// Type of account
    /// </summary>
    public abstract class AccountType
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bonus points.
        /// </summary>
        /// <value>
        /// The bonus points.
        /// </value>
        public int Bonus { get; protected set; }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Adds the bonus points to account.
        /// </summary>
        public abstract void AddBonus();

        /// <summary>
        /// Withdraws the bonus points from account.
        /// </summary>
        public abstract void WithdrawBonus();

        #endregion
    }
}
