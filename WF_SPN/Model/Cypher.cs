using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;

namespace Lib
{
    public class Cypher
    {
        private readonly Dictionary<int, int> pBox, sBox, reverseSBox, reversePBox;

        public Dictionary<int, int> PBox => pBox;
        public Dictionary<int, int> SBox => sBox;

        public Cypher()
        {
            this.pBox = new Dictionary<int, int>()
            {
                { 0, 4 },
                { 1, 6 },
                { 2, 1 },
                { 3, 11 },
                { 4, 8 },
                { 5, 5 },
                { 6, 3 },
                { 7, 2 },
                { 8, 10 },
                { 9, 7 },
                { 10, 0 },
                { 11, 9 },
            };
     
            this.sBox = new Dictionary<int, int>()
            {
                { 0, 4 },
                { 1, 2 },
                { 2, 6 },
                { 3, 1 },
                { 4, 7 },
                { 5, 0 },
                { 6, 5 },
                { 7, 3 },
            };

            this.reversePBox = this.pBox.ToDictionary(x => x.Value, x => x.Key);
            this.reverseSBox = this.sBox.ToDictionary(x => x.Value, x => x.Key);
        }

        /// <summary>
        /// Applica la PBox
        /// </summary>
        /// <param name="binaryString">numero binario.</param>
        /// <returns>Numero binario con l'applicazione della PBox.</returns>
        private String ApplyPBox(string binaryString, Dictionary<int, int> pBox)
        {
            int[] pBoxArr = new int[binaryString.Length];
            binaryString.ToArray();

            // Appena mi accorgo che l'indice della stringa corrisponde a quello della chiave della pbox
            // Sposto la stringa con la posizione (quindi del valore) della pbox
            foreach (KeyValuePair<int, int> p in pBox)
            {
                int key = p.Key;
                int value = p.Value;
                pBoxArr[value] = Convert.ToInt32(binaryString[key].ToString());
            }

            string newBinaryString = "";

            // Ricompongo il numero binario
            for (int i = 0; i < pBoxArr.Length; i++)
            {
                newBinaryString += pBoxArr[i].ToString();
            }

            return newBinaryString;
        }

        public string GetPBoxResult(string binaryString)
        {
            return ApplyPBox(binaryString, this.pBox);
        }

        public string GetReversePBoxResult(string binaryString)
        {
            return ApplyPBox(binaryString, this.reversePBox);
        }

        private string ApplySBox(string binaryString, Dictionary<int, int> sBOX)
        {
            // Divido in terne
            List<string> quattroTerneStr = new List<string>();
            string terna = "";

            for (int i = 0; i < binaryString.Length; i++)
            {
                terna += binaryString[i].ToString();

                if ((i + 1) % 3 == 0)
                {
                    quattroTerneStr.Add(terna);
                    terna = "";
                }
            }

            // Aggiungo l'ultima terna se la lunghezza totale non è un multiplo di 3
            if (terna.Length > 0)
            {
                quattroTerneStr.Add(terna);
            }

            List<int> quattroTerneInt = new List<int>();

            // converto in decimali
            foreach (string ternaBinaria in quattroTerneStr)
            {
                quattroTerneInt.Add(ConvertToDecimal(ternaBinaria));
            }

            // Creo un array risultato
            int[] sBoxArrInt = new int[quattroTerneInt.Count];

            // Popolo l'array risultato con i nuovi valori
            for (int i = 0; i < quattroTerneInt.Count; i++)
            {
                sBoxArrInt[i] = sBOX[quattroTerneInt[i]];
            }

            String newBinaryString = "";

            // Ricompongo il numero binario
            for (int i = 0; i < sBoxArrInt.Length; i++)
            {
                newBinaryString += ConvertToBinary(sBoxArrInt[i]);
            }
            return newBinaryString;
        }

        public string GetSBoxResult(string binaryString)
        {
            return ApplySBox(binaryString, this.sBox);
        }

        public string GetReverseSBoxResult(string binaryString)
        {
            return ApplySBox(binaryString, this.reverseSBox);
        }

        public static String ConvertToBinary(int numero)
        {
            if (numero == 0)
            {
                return "000";
            }
            else if (numero == 1)
            {
                return "001";
            }
            else
            {
                // Creo una stringa vuota per memorizzare la rappresentazione binaria
                string binario = "";

                // Ciclo finché il numero è diverso da zero
                while (numero > 0)
                {
                    // Aggiungo il resto della divisione per 2 alla stringa binaria
                    binario = (numero % 2) + binario;

                    // Divido il numero per 2 e lo arrotondo per troncare la parte decimale
                    numero /= 2;
                }

                // Aggiungo gli zeri davanti con il metodo PadLeft
                binario = binario.PadLeft(3, '0');

                // Restituisco la stringa binaria
                return binario;
            }
        }

        public static int ConvertToDecimal(string binario)
        {
            int decimale = 0;
            int potenza = 1;

            // Ciclo dalla fine della stringa all'inizio
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                // Calcolo del valore della cifra binaria
                int valore = binario[i] - '0';

                // Aggiungo il valore alla variabile decimale
                decimale += valore * potenza;

                // Raddoppio della potenza di 2
                potenza *= 2;
            }

            // Restituzione del numero decimale
            return decimale;
        }

        public static String Xor(String binario1, String binario2)
        {
            string risultato = "";

            // Ciclo per confrontare i caratteri
            for (int i = 0; i < binario1.Length; i++)
            {
                // Calcolo del bit XOR
                char bitRisultato = (binario1[i] == binario2[i]) ? '0' : '1';

                // Concatenazione del bit al risultato
                risultato += bitRisultato;
            }

            // Restituzione del risultato
            return risultato;
        }

        public Dictionary<int, int> PBoxApplication(Dictionary<int, int> dict)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();

            // Per ogni elemento della pbox
            foreach (var pairPbox in this.pBox)
            {
                int keyPbox = pairPbox.Key;

                // Controllo se la chiave della PBox è presente nel dizionario
                if (dict.TryGetValue(keyPbox, out int valueDict))
                {
                    temp.Add(keyPbox, valueDict);
                }
            }

            return temp; // Ritorno { (1: 1), (2: 0), (3: 1), ... }
        }

        public Dictionary<int, int> SBoxApplication(Dictionary<int, int> dict)
        {
            List<int> list = new List<int>();
            int i = 0;
            string temp = "";

            // Divido in terne
            foreach (var pairDict in dict)
            {
                temp += pairDict.Value;
                i += 1;

                if (i == 3)
                {
                    list.Add(ConvertToDecimal(temp));
                    temp = "";
                    i = 0;
                }
            }

            // Creo un dictionary per ciclare
            Dictionary<int, int> tempDict = new Dictionary<int, int>();
            int k = 0;

            foreach (int s in list)
            {
                tempDict.Add(k, s);
                k += 1;
            }

            // Per ogni elemento della sbox
            foreach (var pairSbox in this.sBox)
            {
                int keyPbox = pairSbox.Key;

                // Controllo se la chiave della SBox è presente nel dizionario
                if (tempDict.TryGetValue(keyPbox, out int valueDict))
                {
                    tempDict[keyPbox] = valueDict;
                }
            }

            return tempDict;
        }

        public String Cipher(String testoInChiaro, String chiave1, String chiave2)
        {
            String xor = Xor(testoInChiaro,chiave1);
            String strPbox = this.GetPBoxResult(xor);
            String strSbox = this.GetSBoxResult(strPbox);
            xor = Xor(chiave1, chiave2);
            xor = Xor(xor, strSbox);
            strPbox = this.GetPBoxResult(xor);
            strSbox = this.GetSBoxResult(strPbox);
            return strSbox;
        }

        public String DeCipher(String ciphertext, String key1, String key2)
        {
            ciphertext = this.GetReverseSBoxResult(ciphertext);
            ciphertext = this.GetReversePBoxResult(ciphertext);
            ciphertext = Xor(ciphertext, Xor(key1, key2));
            ciphertext = this.GetReverseSBoxResult(ciphertext);
            ciphertext = this.GetReversePBoxResult(ciphertext);
            ciphertext = Xor(ciphertext, key1);
            return ciphertext;
        }
    }
}