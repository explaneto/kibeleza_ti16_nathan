using System;

namespace kibeleza_ti16_nathan
{
    public static class variaveis
    {
        //Geral
        public static string funcao;
        public static int linha_selecionada;

        //Login
        public static string usuario, senha, nivel;

        //Cliente
        public static int cod_cliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente, atFotoCliente, caminhoFotoCliente;
        public static DateTime dataCadastroCliente;

        //Empresa
        public static int cod_empresa;
        public static string nomeEmpresa, cnpjCpfEmpresa, razaoSocialEmpresa, emailEmpresa, statusEmpresa;
        public static DateTime dataCadastroEmpresa, horarioAtendEmpresa;

        //Fone Empresa
        public static int cod_fone_empresa;
        public static string numeroFoneEmpresa, operadoraEmpresa, descricaoEmpresa;

        //Cliente
        public static int cod_fone_cliente;
        public static string numeroFoneCliente, operadoraCliente, operFoneCliente, descricaoCliente;

        //FOTOS FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp = "ti16";
        public static string senhaFtp = "1234";

        //RESERVA
        public static int cod_reserva;
        public static string obsReserva, statusReserva, codFuncionario, codCliente, codServico;
        public static DateTime dataReserva, horarioReserva;

        //FUNCIONARIO
        public static int cod_funcionario;
        public static string nomeFuncionario;


        //SERVICO
        public static int cod_servico;
        public static string nomeServico;

        //RELATORIO
        public static string relatorio;

    }
}
