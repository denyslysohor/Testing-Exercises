interface Loan {
    principal: number,
    interestRate: number,
}

interface ConventionalLoan extends Loan {
    months: number
}

function calculateInterestOnlyLoanPayment(loanTerms: Loan): string {

    let interest = loanTerms.interestRate / 1200;
    let payment;
    payment = loanTerms.principal * interest;
    return 'The interest only loan payment is ' + payment.toFixed(2);
}

let interestOnlyPayment = calculateInterestOnlyLoanPayment({principal: 30000, interestRate: 5});
console.log(interestOnlyPayment);