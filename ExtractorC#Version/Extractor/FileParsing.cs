using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCsharp
{
    class FileParsing
    {
        private ArrayList time = new ArrayList();

        private int[][] node1InputsArr;
        private int[][] node1OutputsArr;

        private int[][] node2InputsArr;
        private int[][] node2OutputsArr;

        private int[][] node3InputsArr;
        private int[][] node3OutputsArr;

        private int[][] node4InputsArr;
        private int[][] node4OutputsArr;

        public FileParsing(Stream fileContent)
        {
            string currentLine;
            ArrayList node1Inputs = new ArrayList();
            ArrayList node1Outputs = new ArrayList();

            ArrayList node1InputsBin = new ArrayList();
            ArrayList node1OutputsBin = new ArrayList();

            ArrayList node2Inputs = new ArrayList();
            ArrayList node2Outputs = new ArrayList();

            ArrayList node2InputsBin = new ArrayList();
            ArrayList node2OutputsBin = new ArrayList();

            int i = 0;


            using (StreamReader sc = new StreamReader(fileContent))
            {
                while((currentLine = sc.ReadLine()) != null)
                {
                    if (i != 0)
                    {
                        int length = currentLine.Length;
                        time.Add(currentLine.Substring(0, 19));
                        node1Inputs.Add(currentLine.Substring(20, 8));
                        node1Outputs.Add(currentLine.Substring(29, 8));
                        node2Inputs.Add(currentLine.Substring(38, 8));
                        node2Outputs.Add(currentLine.Substring(47, 8));
                    }
                    i++;
                }
                sc.Close();
            }
            
        }






        public String hexToBinary(String hex)
        {

            return Convert.ToString(Convert.ToInt64(hex, 16), 2);

        }

        public ArrayList autoHextoBinary(ArrayList hexArray)
        {
            ArrayList binArray = new ArrayList();
            foreach(String hex in hexArray)
            {
                binArray.Add(hexToBinary(hex));
            }
            return binArray;
        }


        public int[] parseBinToArray(String bin)
        {
            int[] binArray = new int[32];
            int lengthBin = bin.Length;
            if (lengthBin < 32)
            {
                int zerosToAdd = 32 - lengthBin;
                for (int j = 0; j < zerosToAdd; j++)
                {
                    bin = "0" + bin;
                }
            }
            for (int i = 0; i < binArray.Length; i++)
            {
                binArray[i] = Int32.Parse(bin.Substring(i, i + 1));
            }
            return binArray;
        }

        public String parseBinToString(String bin)
        {
            int[] binArray = parseBinToArray(bin);
            String parsedBin = "";
            foreach(int bit in binArray)
            {
                parsedBin += bit;
                parsedBin += ",";
            }
            return parsedBin;
        }



        public ArrayList getTime()
        {
            return time;
        }

        public void setTime(ArrayList time)
        {
            this.time = time;
        }

        public int[][] getNode1InputsArr()
        {
            return node1InputsArr;
        }

        public void setNode1InputsArr(int[][] node1InputsArr)
        {
            this.node1InputsArr = node1InputsArr;
        }

        public int[][] getNode1OutputsArr()
        {
            return node1OutputsArr;
        }

        public void setNode1OutputsArr(int[][] node1OutputsArr)
        {
            this.node1OutputsArr = node1OutputsArr;
        }

        public int[][] getNode2InputsArr()
        {
            return node2InputsArr;
        }

        public void setNode2InputsArr(int[][] node2InputsArr)
        {
            this.node2InputsArr = node2InputsArr;
        }

        public int[][] getNode2OutputsArr()
        {
            return node2OutputsArr;
        }

        public void setNode2OutputsArr(int[][] node2OutputsArr)
        {
            this.node2OutputsArr = node2OutputsArr;
        }

        public int[][] getNode3InputsArr()
        {
            return node3InputsArr;
        }

        public void setNode3InputsArr(int[][] node3InputsArr)
        {
            this.node3InputsArr = node3InputsArr;
        }

        public int[][] getNode3OutputsArr()
        {
            return node3OutputsArr;
        }

        public void setNode3OutputsArr(int[][] node3OutputsArr)
        {
            this.node3OutputsArr = node3OutputsArr;
        }

        public int[][] getNode4InputsArr()
        {
            return node4InputsArr;
        }

        public void setNode4InputsArr(int[][] node4InputsArr)
        {
            this.node4InputsArr = node4InputsArr;
        }

        public int[][] getNode4OutputsArr()
        {
            return node4OutputsArr;
        }

        public void setNode4OutputsArr(int[][] node4OutputsArr)
        {
            this.node4OutputsArr = node4OutputsArr;
        }

    }
}
