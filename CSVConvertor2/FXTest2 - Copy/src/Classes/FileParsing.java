package sample;
import java.io.*;
import java.util.*;

public class FileParsing
{
    //Contains times for each csv line entry. In Date:time format (will be refined in Controller.java)
    private ArrayList<String> time = new ArrayList<String>();

    //Declarations of 2D Arrays containing 32-bit binary arrays in a list. Ex. { [0,0,0,0,...], [0,0,0,0,...], [0,0,0,0,...] }
    private int[][] node1InputsArr;
    private int[][] node1OutputsArr;

    private int[][] node2InputsArr;
    private int[][] node2OutputsArr;

    private int[][] node3InputsArr;
    private int[][] node3OutputsArr;

    private int[][] node4InputsArr;
    private int[][] node4OutputsArr;
    /*
        Constructor takes a file passed into as a parameter
        File is then read line-by-line by Scanner
        Each Line is then parsed and stored into arrays
     */
    FileParsing(File file) throws FileNotFoundException {

        Scanner sc = new Scanner(file);


        ArrayList<String> node1Inputs = new ArrayList<String>();
        ArrayList<String> node1Outputs = new ArrayList<String>();

        ArrayList<String> node1InputsBin = new ArrayList<String>();
        ArrayList<String> node1OutputsBin = new ArrayList<String>();

        ArrayList<String> node2Inputs = new ArrayList<String>();
        ArrayList<String> node2Outputs = new ArrayList<String>();

        ArrayList<String> node2InputsBin = new ArrayList<String>();
        ArrayList<String> node2OutputsBin = new ArrayList<String>();

        ArrayList<String> node3Inputs = new ArrayList<String>();
        ArrayList<String> node3Outputs = new ArrayList<String>();

        ArrayList<String> node3InputsBin = new ArrayList<String>();
        ArrayList<String> node3OutputsBin = new ArrayList<String>();

        ArrayList<String> node4Inputs = new ArrayList<String>();
        ArrayList<String> node4Outputs = new ArrayList<String>();

        ArrayList<String> node4InputsBin = new ArrayList<String>();
        ArrayList<String> node4OutputsBin = new ArrayList<String>();

        int i = 0;
        //Example .csv line: "6/16/2021 2:26:35PM0CFA80000400000C22DA64FF1940044034000000FC000040"

        while (sc.hasNext())  //returns a boolean value
        {
            String item = sc.nextLine();
            int length = item.length();
            if(i !=0)           //skip the first row because it contains titles, not data
            {
                //First 19 chars define time
                time.add(item.substring(0, 19));
                node1Inputs.add(item.substring(20, 28));            //Next 8 define Node 1 Inputs
                node1Outputs.add(item.substring(29, 37));           //Next 8 define next node, etc


                node2Inputs.add(item.substring(38, 46));
                node2Outputs.add(item.substring(47, 55));
                if(length < 80 && length > 66)                  //range given for Node 3's data location (checks if node 3 exists)
                {
                    node3Inputs.add(item.substring(56, 64));
                    node3Outputs.add(item.substring(65, 73));
                }
                if(length < 100 && length > 88)                 //range given for Node 4's data location (checks if node 4 exists)
                {
                    node4Inputs.add(item.substring(74, 82));
                    node4Outputs.add(item.substring(83, 91));
                }
            }

            i++;
        }

        //node1Inputs is a hex array. Convert all hex strings in each node to binary strings
        node1InputsBin = autoHextoBinary(node1Inputs);
        node1OutputsBin = autoHextoBinary(node1Outputs);

        node2InputsBin = autoHextoBinary(node2Inputs);
        node2OutputsBin = autoHextoBinary(node2Outputs);

        node3InputsBin = autoHextoBinary(node3Inputs);
        node3OutputsBin = autoHextoBinary(node3Outputs);

        node4InputsBin = autoHextoBinary(node4Inputs);
        node4OutputsBin = autoHextoBinary(node4Outputs);

        //Declare and instantiate 2D arrays containing lists of binary arrays (easier for location-finding later)
        node1InputsArr = new int[node1InputsBin.size()][32];
        node1OutputsArr = new int[node1OutputsBin.size()][32];

        node2InputsArr = new int[node2InputsBin.size()][32];
        node2OutputsArr = new int[node2OutputsBin.size()][32];

        node3InputsArr = new int[node3InputsBin.size()][32];
        node3OutputsArr = new int[node3OutputsBin.size()][32];

        node4InputsArr = new int[node4InputsBin.size()][32];
        node4OutputsArr = new int[node4OutputsBin.size()][32];

        //Convert each binary-String Array to a 2D binary array

        for(int j = 0; j < node1InputsBin.size(); j++)
        {
            String bin = node1InputsBin.get(j);
            node1InputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node1OutputsBin.size(); j++)
        {
            String bin = node1OutputsBin.get(j);
            node1OutputsArr[j] = parseBinToArray(bin);
        }
        for(int j = 0; j < node2InputsBin.size(); j++)
        {
            String bin = node2InputsBin.get(j);
            node2InputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node2OutputsBin.size(); j++)
        {
            String bin = node2OutputsBin.get(j);
            node2OutputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node3InputsBin.size(); j++)
        {
            String bin = node3InputsBin.get(j);
            node3InputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node3OutputsBin.size(); j++)
        {
            String bin = node3OutputsBin.get(j);
            node3OutputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node4InputsBin.size(); j++)
        {
            String bin = node4InputsBin.get(j);
            node4InputsArr[j] = parseBinToArray(bin);
        }

        for(int j = 0; j < node4OutputsBin.size(); j++)
        {
            String bin = node4OutputsBin.get(j);
            node4OutputsArr[j] = parseBinToArray(bin);
        }

        sc.close();
    }

    /*
    Converts hex strings to binary strings
     */
    public String hexToBinary(String hex)
    {

        long i = Long.parseLong(hex, 16);
        String bin = Long.toBinaryString(i);
        return bin;

    }

    /*
    Automatically takes a hex-string array and converts it to binary-string array
     */
    public ArrayList<String> autoHextoBinary(ArrayList<String> hexArray)
    {
        ArrayList<String> binArray = new ArrayList<String>();
        for(String hex: hexArray)
        {
            binArray.add(hexToBinary(hex));
        }
        return binArray;
    }

    /*
    Takes a String bin (32-bit) and parses it into an array of length 32
     */
    public int[] parseBinToArray(String bin)
    {
        int[] binArray = new int[32];
        int lengthBin = bin.length();
        if (lengthBin < 32)                     //Add padding to front in case hex values were low before converting to bin-string
        {
            int zerosToAdd = 32-lengthBin;
            for(int j = 0; j < zerosToAdd; j++)
            {
                bin = "0" + bin;
            }
        }
        for(int i = 0; i < binArray.length; i++)
        {
            binArray[i] = Integer.parseInt(bin.substring(i, i+1));
        }
        return binArray;
    }

    /*
    If needed, method available to convert a 32-bit binary string into a spaced-out 32-bit binary string
     */
    public String parseBinToString(String bin)
    {
        int[] binArray = parseBinToArray(bin);
        String parsedBin = "";
        for(int bit: binArray)
        {
            parsedBin += bit;
            parsedBin += ",";
        }
        return parsedBin;
    }

    /*
    If needed, number of nodes in the file can be calculated
     */
    public int numberOfNodes()
    {
        if(node3InputsArr != null)
        {
            return 3;
        }
        else if(node4InputsArr != null)
            return 4;
        return 2;
    }


    //<editor-fold desc="Getters and Setters">
    public ArrayList<String> getTime() {
        return time;
    }

    public void setTime(ArrayList<String> time) {
        this.time = time;
    }

    public int[][] getNode1InputsArr() {
        return node1InputsArr;
    }

    public void setNode1InputsArr(int[][] node1InputsArr) {
        this.node1InputsArr = node1InputsArr;
    }

    public int[][] getNode1OutputsArr() {
        return node1OutputsArr;
    }

    public void setNode1OutputsArr(int[][] node1OutputsArr) {
        this.node1OutputsArr = node1OutputsArr;
    }

    public int[][] getNode2InputsArr() {
        return node2InputsArr;
    }

    public void setNode2InputsArr(int[][] node2InputsArr) {
        this.node2InputsArr = node2InputsArr;
    }

    public int[][] getNode2OutputsArr() {
        return node2OutputsArr;
    }

    public void setNode2OutputsArr(int[][] node2OutputsArr) {
        this.node2OutputsArr = node2OutputsArr;
    }

    public int[][] getNode3InputsArr() {
        return node3InputsArr;
    }

    public void setNode3InputsArr(int[][] node3InputsArr) {
        this.node3InputsArr = node3InputsArr;
    }

    public int[][] getNode3OutputsArr() {
        return node3OutputsArr;
    }

    public void setNode3OutputsArr(int[][] node3OutputsArr) {
        this.node3OutputsArr = node3OutputsArr;
    }

    public int[][] getNode4InputsArr() {
        return node4InputsArr;
    }

    public void setNode4InputsArr(int[][] node4InputsArr) {
        this.node4InputsArr = node4InputsArr;
    }

    public int[][] getNode4OutputsArr() {
        return node4OutputsArr;
    }

    public void setNode4OutputsArr(int[][] node4OutputsArr) {
        this.node4OutputsArr = node4OutputsArr;
    }
    //</editor-fold>

}
