ClientePF pf = new ClientePF();

pf._telefoneDeContato = "69 9 98078976";
pf._dataCadSistema = "03/12/2025";
pf._nome = "Joao do teste";
pf._email = "joao@teste";
pf._cpf = "02358975675";
Servicos sv = new Servicos();
sv._descricao = "Troca de oleo de macaco";
sv._valorSugerido = 180.00;
sv._tempoEstimado = 2;
OrdemServico odS = new OrdemServico();
odS._dataInicio = "2025 / 02 / 02";
odS._status = true;
//vincular ao cliente 1
odS.cliente = pf;//slk num é assim  n verificar dipues
ItemServico itS = new ItemServico();
itS._valorUnit = 180.00;
itS._quantidade = 2;
itS.ordemServico = odS;

