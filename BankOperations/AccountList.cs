using System;
using System.Collections.Generic;

namespace BankOperations
{
    /// <summary>
    /// List of accounts
    /// </summary>
    public sealed class AccountList
    {
        #region PrivateFields

        /// <summary>
        /// The accounts
        /// </summary>
        private List<BankAccount> accounts = new List<BankAccount>();

        #endregion

        #region PublicMethods

        /// <summary>
        /// Add account to the accounts list.
        /// </summary>
        /// <param name="account">The account that we want to add.</param>
        /// <exception cref="System.ArgumentNullException">account is null</exception>
        /// <exception cref="System.ArgumentException">account is already added</exception>
        public void CreateAccount(BankAccount account)
        {
            if (account == null) 
            {
                throw new ArgumentNullException(nameof(account));
            }

            if (this.accounts.Contains(account)) 
            {
                throw new ArgumentException(nameof(account));
            }

            this.accounts.Add(account);
        }

        /// <summary>
        /// Deletes the account.
        /// </summary>
        /// <param name="id">The identifier of account.</param>
        /// <exception cref="System.ArgumentNullException">id is null</exception>
        public void DeleteAccount(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            foreach (var account in this.accounts) 
            {
                if (account.Id.ToString() == id)
                {
                    this.accounts.Remove(account);
                    return;
                }
            }
        }

        #endregion
    }
}
