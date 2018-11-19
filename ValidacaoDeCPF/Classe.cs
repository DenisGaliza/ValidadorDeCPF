using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeCPF
{
    public class Util
    {
        public bool ValidaCpf(String Cpf)
        {
         



            try
             {

                //variaveis
                Boolean a, d;
                Int64 R = Convert.ToInt64(Cpf);





                // Convert.ToDecimal(txtCpf);
                decimal dig1 = Convert.ToDecimal(Cpf.Substring(0, 1));
                decimal dig2 = Convert.ToDecimal(Cpf.Substring(1, 1));
                decimal dig3 = Convert.ToDecimal(Cpf.Substring(2, 1));
                decimal dig4 = Convert.ToDecimal(Cpf.Substring(3, 1));
                decimal dig5 = Convert.ToDecimal(Cpf.Substring(4, 1));
                decimal dig6 = Convert.ToDecimal(Cpf.Substring(5, 1));
                decimal dig7 = Convert.ToDecimal(Cpf.Substring(6, 1));
                decimal dig8 = Convert.ToDecimal(Cpf.Substring(7, 1));
                decimal dig9 = Convert.ToDecimal(Cpf.Substring(8, 1));
                decimal dig10 = Convert.ToDecimal(Cpf.Substring(9, 1));
                decimal dig11 = Convert.ToDecimal(Cpf.Substring(10, 1));






                //Primeiro Digito Verificador
                decimal num1 = dig1 * 10;
                decimal num2 = dig2 * 9;
                decimal num3 = dig3 * 8;
                decimal num4 = dig4 * 7;
                decimal num5 = dig5 * 6;
                decimal num6 = dig6 * 5;
                decimal num7 = dig7 * 4;
                decimal num8 = dig8 * 3;
                decimal num9 = dig9 * 2;


                //
                decimal result1 = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9) % 11;

                //Segundo digito Verificador
                decimal num01 = dig1 * 11;
                decimal num02 = dig2 * 10;
                decimal num03 = dig3 * 9;
                decimal num04 = dig4 * 8;
                decimal num05 = dig5 * 7;
                decimal num06 = dig6 * 6;
                decimal num07 = dig7 * 5;
                decimal num08 = dig8 * 4;
                decimal num09 = dig9 * 3;
                decimal num010 = dig10 * 2;

                decimal result2 = (num01 + num02 + num03 + num04 + num05 + num06 + num07 + num08 + num09 + num010) % 11;

                //Verificando Primeiro Digito


                if (result1 < 2)
                {
                    if (dig10 == 0)
                    {

                        d = true;

                    }
                    else
                    {

                        d = false;
                    }
                }
                else
                {

                    decimal result01 = 11 - result1;
                    if (dig10 == result01)
                    {

                        d = true;
                    }
                    else
                    {

                        d = false;
                    }
                }



                //Verificando Segundo Digito
                if (result2 < 2)
                {
                    if (dig11 == 0)
                    {
                        a = true;
                    }
                    else
                    {
                        a = false;
                    }
                }
                else
                {
                    decimal result02 = 11 - result2;
                    if (dig11 == result02)
                    {
                        a = true;
                    }
                    else
                    {

                        a = false;
                    }
                }


                //Saida                          
                if ((R == 00000000000) || (R == 11111111111) || (R == 22222222222) || (R == 33333333333) || (R == 44444444444) || (R == 55555555555) || (R == 66666666666) || (R == 77777777777) || (R == 88888888888) || (R == 99999999999))
                {
                    return false;
                }
                else if (R > 99999999999)
                {
                    return false;
                }
                else if (d == true && a == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }








            }
            catch (Exception)
            {

                return false;
            }
        }
            }
        }

    

