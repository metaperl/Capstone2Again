module Model


type Customer = { name: string }

type Acccount = 
    { balance: int
      id: string
      customer: Customer }

