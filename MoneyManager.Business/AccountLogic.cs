﻿namespace MoneyManager.Business
{
    //TODO: Refactor
    //internal class AccountLogic
    //{
    //    public void RemoveTransactionAmount(FinancialTransaction transaction)
    //    {
    //        PrehandleRemoveIfTransfer(transaction);

    //        Func<double, double> amountFunc = (x) =>
    //            transaction.Type == (int)TransactionType.Income
    //                ? -x
    //                : x;

    //        HandleTransactionAmount(transaction, amountFunc, GetChargedAccountFunc());
    //    }

    //    public void AddTransactionAmount(FinancialTransaction transaction)
    //    {
    //        PrehandleAddIfTransfer(transaction);

    //        Func<double, double> amountFunc = (x) =>
    //            transaction.Type == (int)TransactionType.Income
    //                ? x
    //                : -x;

    //        HandleTransactionAmount(transaction, amountFunc, GetChargedAccountFunc());
    //    }

    //    private void PrehandleAddIfTransfer(FinancialTransaction transaction)
    //    {
    //        if (transaction.Type == (int)TransactionType.Transfer)
    //        {
    //            Func<double, double> amountFunc = x => x;
    //            HandleTransactionAmount(transaction, amountFunc, GetTargetAccountFunc());
    //        }
    //    }

    //    private void PrehandleRemoveIfTransfer(FinancialTransaction transaction)
    //    {
    //        if (transaction.Type == (int)TransactionType.Transfer)
    //        {
    //            Func<double, double> amountFunc = x => -x;
    //            HandleTransactionAmount(transaction, amountFunc, GetTargetAccountFunc());
    //        }
    //    }

    //    private Func<FinancialTransaction, Account> GetTargetAccountFunc()
    //    {
    //        Func<FinancialTransaction, Account> targetAccountFunc =
    //            (trans) => AllAccounts.FirstOrDefault(x => x.Id == trans.TargetAccountId);
    //        return targetAccountFunc;
    //    }

    //    private Func<FinancialTransaction, Account> GetChargedAccountFunc()
    //    {
    //        Func<FinancialTransaction, Account> accountFunc =
    //            (trans) => AllAccounts.FirstOrDefault(x => x.Id == trans.ChargedAccountId);
    //        return accountFunc;
    //    }

    //    private void HandleTransactionAmount(FinancialTransaction transaction, Func<double, double> amountFunc, Func<FinancialTransaction, Account> getAccountFunc)
    //    {
    //        if (transaction.ClearTransactionNow)
    //        {
    //            var account = getAccountFunc(transaction);
    //            if (account == null) return;

    //            var amount = amountFunc(transaction.Amount);

    //            account.CurrentBalance += amount;
    //            transaction.Cleared = true;
    //            UpdateItem(account);
    //        }
    //    }
    //}
}