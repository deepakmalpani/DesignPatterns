AccountService accountService = new AccountService();
LoanService loanService = new LoanService();
TransactionService transactionService = new TransactionService();

accountService.CreateAccount();
loanService.ApproveLoan();
transactionService.TransferMoney();