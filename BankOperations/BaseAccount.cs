using System;
using System.Configuration;

namespace BankOperations
{
    /// <summary>
    /// Bank account with base status
    /// </summary>
    /// <seealso cref="BankOperations.AccountType" />
    public sealed class BaseAccount : AccountType
    {
        #region PrivateFields

        /// <summary>
        /// The add bonus "cost"
        /// </summary>
        private static readonly int AddBonusCost;

        /// <summary>
        /// The withdraw bonus "cost"
        /// </summary>
        private static readonly int WithdrawBonusCost;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes static members of the <see cref="BaseAccount"/> class.
        /// </summary>
        /// <exception cref="System.Exception">error of reading config file or invalid data from this file</exception>
        static BaseAccount()
        {
            try
            {
                AddBonusCost = int.Parse(System.Configuration.ConfigurationManager.AppSettings["baseAddBonus"]);
                WithdrawBonusCost = int.Parse(System.Configuration.ConfigurationManager.AppSettings["baseWithdrawBonus"]);
                if (WithdrawBonusCost > AddBonusCost)
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                AddBonusCost = 2;
                WithdrawBonusCost = 1;
            }
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Adds the bonus points to account.
        /// </summary>
        public override void AddBonus()
        {
            this.Bonus += AddBonusCost;
        }

        /// <summary>
        /// Withdraws the bonus points from account.
        /// </summary>
        public override void WithdrawBonus()
        {
            this.Bonus -= WithdrawBonusCost;
        }

        #endregion
    }
}
