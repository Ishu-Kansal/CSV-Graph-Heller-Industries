package sample;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.chart.LineChart;
import javafx.scene.chart.XYChart;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.stage.FileChooser;
import javafx.stage.Stage;

import java.io.File;
import java.io.FileNotFoundException;
import java.net.URL;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    FileChooser fileChooser = new FileChooser();
    //Declare all combobox values. -1 means that combobox is not used.
    private int combo1 = -1;
    private int combo2 = -1;
    private int combo3 = -1;
    private int combo4 = -1;
    private int combo5 = -1;
    private int combo6 = -1;
    private int combo7 = -1;
    private int combo8 = -1;
    private int combo9 = -1;
    private int combo10 = -1;

    //Declare digital values. Initialized to -1 meaning that combobox has not been selected.
    private int digital1 = -1;
    private int digital2 = -1;
    private int digital3 = -1;
    private int digital4 = -1;
    private int digital5 = -1;
    private int digital6 = -1;
    private int digital7 = -1;
    private int digital8 = -1;
    private int digital9 = -1;
    private int digital10 = -1;

    File csvFile;

    String startTime;
    String endTime;

        private int startIndex = -1;
        private int endIndex = -1;

    FileParsing parse;
    ArrayList<String> myTimes = new ArrayList<String>();


    @FXML
    private TextField filePathDisplay;

    @FXML
    void getFile(MouseEvent event) throws FileNotFoundException
    {
        csvFile = fileChooser.showOpenDialog(new Stage());      //Allows user to choose a file
        String path = csvFile.getAbsolutePath();
        filePathDisplay.setText(path);                          //Print out path of file after selection
    }


    //<editor-fold desc="Declarations of Comboboxes">

    //Declaration of combo boxes. Box 1 is at bottom, and Box 10 is at top
    @FXML
    private ComboBox comb;

    @FXML
    private ComboBox comb2;

    @FXML
    private ComboBox comb5;

    @FXML
    private ComboBox comb3;

    @FXML
    private ComboBox comb4;

    @FXML
    private ComboBox comb6;

    @FXML
    private ComboBox comb7;

    @FXML
    private ComboBox comb8;

    @FXML
    private ComboBox comb9;

    @FXML
    private ComboBox comb10;


    //</editor-fold>


    //<editor-fold desc="Node Selection">
    @FXML
    void select1st(ActionEvent event)
    {
        String chosen = comb.getSelectionModel().getSelectedItem().toString();      //Read Combo box selection
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo1 = 2;
            digital1 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo1 = 2;
            digital1 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo1 = 1;
            digital1 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo1 = 1;
            digital1 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo1 = 3;
            digital1 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo1 = 3;
            digital1 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo1 = 3;
            digital1 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo1 = 3;
            digital1 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo1 = 3;
            digital1 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo1 = 3;
            digital1 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo1 = 4;
            digital1 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo1 = 3;
            digital1 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo1 = 4;
            digital1 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo1 = 3;
            digital1 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo1 = 3;
            digital1  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo1 = 1;
            digital1 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo1 = 1;
            digital1 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo1 = 1;
            digital1 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo1 = 1;
            digital1 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo1 = 2;
            digital1 = 27;
        }

        else
            combo1 = -1;
    }

    @FXML
    void select2nd(ActionEvent event) {
        String chosen = comb2.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo2 = 2;
            digital2 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo2 = 2;
            digital2 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo2 = 1;
            digital2 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo2 = 1;
            digital2 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo2 = 3;
            digital2 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo2 = 3;
            digital2 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo2 = 3;
            digital2 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo2 = 3;
            digital2 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo2 = 3;
            digital2 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo2 = 3;
            digital2 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo2 = 4;
            digital2 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo2 = 3;
            digital2 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo2 = 4;
            digital2 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo2 = 3;
            digital2 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo2 = 3;
            digital2  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo2 = 1;
            digital2 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo2 = 1;
            digital2 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo2 = 1;
            digital2 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo2 = 1;
            digital2 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo2 = 2;
            digital2 = 27;
        }

        else
            combo2 = -1;
    }

    @FXML
    void select3rd(ActionEvent event)
    {
        String chosen = comb3.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo3 = 2;
            digital3 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo3 = 2;
            digital3 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo3 = 1;
            digital3 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo3 = 1;
            digital3 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo3 = 3;
            digital3 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo3 = 3;
            digital3 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo3 = 3;
            digital3 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo3 = 3;
            digital3 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo3 = 3;
            digital3 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo3 = 3;
            digital3 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo3 = 4;
            digital3 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo3 = 3;
            digital3 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo3 = 4;
            digital3 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo3 = 3;
            digital3 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo3 = 3;
            digital3  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo3 = 1;
            digital3 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo3 = 1;
            digital3 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo3 = 1;
            digital3 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo3 = 1;
            digital3 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo3 = 2;
            digital3 = 27;
        }

        else
            combo3 = -1;
    }

    @FXML
    void select4th(ActionEvent event) {
        String chosen = comb4.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo4 = 2;
            digital4 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo4 = 2;
            digital4 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo4 = 1;
            digital4 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo4 = 1;
            digital4 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo4 = 3;
            digital4 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo4 = 3;
            digital4 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo4 = 3;
            digital4 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo4 = 3;
            digital4 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo4 = 3;
            digital4 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo4 = 3;
            digital4 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo4 = 4;
            digital4 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo4 = 3;
            digital4 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo4 = 4;
            digital4 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo4 = 3;
            digital4 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo4 = 3;
            digital4  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo4 = 1;
            digital4 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo4 = 1;
            digital4 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo4 = 1;
            digital4 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo4 = 1;
            digital4 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo4 = 2;
            digital4 = 27;
        }

        else
            combo4 = -1;
    }

    @FXML
    void select5th(ActionEvent event) {
        String chosen = comb5.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo5 = 2;
            digital5 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo5 = 2;
            digital5 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo5 = 1;
            digital5 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo5 = 1;
            digital5 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo5 = 3;
            digital5 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo5 = 3;
            digital5 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo5 = 3;
            digital5 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo5 = 3;
            digital5 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo5 = 3;
            digital5 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo5 = 3;
            digital5 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo5 = 4;
            digital5 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo5 = 3;
            digital5 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo5 = 4;
            digital5 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo5 = 3;
            digital5 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo5 = 3;
            digital5  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo5 = 1;
            digital5 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo5 = 1;
            digital5 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo5 = 1;
            digital5 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo5 = 1;
            digital5 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo5 = 2;
            digital5 = 27;
        }

        else
            combo5 = -1;
    }

    @FXML
    void select6th(ActionEvent event)
    {
        String chosen = comb6.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo6 = 2;
            digital6 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo6 = 2;
            digital6 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo6 = 1;
            digital6 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo6 = 1;
            digital6 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo6 = 3;
            digital6 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo6 = 3;
            digital6 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo6 = 3;
            digital6 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo6 = 3;
            digital6 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo6 = 3;
            digital6 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo6 = 3;
            digital6 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo6 = 4;
            digital6 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo6 = 3;
            digital6 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo6 = 4;
            digital6 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo6 = 3;
            digital6 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo6 = 3;
            digital6  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo6 = 1;
            digital6 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo6 = 1;
            digital6 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo6 = 1;
            digital6 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo6 = 1;
            digital6 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo6 = 2;
            digital6 = 27;
        }

        else
            combo6 = -1;
    }

    @FXML
    void select7th(ActionEvent event)
    {
        String chosen = comb7.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo7 = 2;
            digital7 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo7 = 2;
            digital7 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo7 = 1;
            digital7 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo7 = 1;
            digital7 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo7 = 3;
            digital7 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo7 = 3;
            digital7 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo7 = 3;
            digital7 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo7 = 3;
            digital7 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo7 = 3;
            digital7 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo7 = 3;
            digital7 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo7 = 4;
            digital7 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo7 = 3;
            digital7 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo7 = 4;
            digital7 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo7 = 3;
            digital7 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo7 = 3;
            digital7  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo7 = 1;
            digital7 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo7 = 1;
            digital7 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo7 = 1;
            digital7 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo7 = 1;
            digital7 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo7 = 2;
            digital7 = 27;
        }

        else
            combo7 = -1;
    }

    @FXML
    void select8th(ActionEvent event) {
        String chosen = comb8.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo8 = 2;
            digital8 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo8 = 2;
            digital8 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo8 = 1;
            digital8 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo8 = 1;
            digital8 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo8 = 3;
            digital8 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo8 = 3;
            digital8 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo8 = 3;
            digital8 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo8 = 3;
            digital8 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo8 = 3;
            digital8 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo8 = 3;
            digital8 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo8 = 4;
            digital8 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo8 = 3;
            digital8 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo8 = 4;
            digital8 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo8 = 3;
            digital8 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo8 = 3;
            digital8  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo8 = 1;
            digital8 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo8 = 1;
            digital8 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo8 = 1;
            digital8 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo8 = 1;
            digital8 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo8 = 2;
            digital8 = 27;
        }

        else
            combo8 = -1;
    }

    @FXML
    void select9th(ActionEvent event) {
        String chosen = comb9.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo9 = 2;
            digital9 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo9 = 2;
            digital9 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo9 = 1;
            digital9 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo9 = 1;
            digital9 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo9 = 3;
            digital9 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo9 = 3;
            digital9 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo9 = 3;
            digital9 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo9 = 3;
            digital9 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo9 = 3;
            digital9 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo9 = 3;
            digital9 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo9 = 4;
            digital9 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo9 = 3;
            digital9 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo9 = 4;
            digital9 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo9 = 3;
            digital9 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo9 = 3;
            digital9  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo9 = 1;
            digital9 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo9 = 1;
            digital9 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo9 = 1;
            digital9 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo9 = 1;
            digital9 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo9 = 2;
            digital9 = 27;
        }

        else
            combo9 = -1;
    }

    @FXML
    void select10th(ActionEvent event) {
        String chosen = comb10.getSelectionModel().getSelectedItem().toString();
        //Hard Coding selection to location of bit.
        // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
        //Digitals: location of bit to-be-graphed within each 32-bit number of each node
        if(chosen.equals("L1 Admit"))
        {
            combo10 = 2;
            digital10 = 31;
        }
        else if (chosen.equals("L2 Admit"))
        {
            combo10 = 2;
            digital10 = 7;
        }
        else if(chosen.equals("S1L1"))
        {
            combo10 = 1;
            digital10 = 3;
        }
        else if(chosen.equals("S1L2"))
        {
            combo10 = 1;
            digital10 = 12;
        }
        else if(chosen.equals("S3L1"))
        {
            combo10 = 3;
            digital10 = 21;
        }
        else if(chosen.equals("S3L2"))
        {
            combo10 = 3;
            digital10 = 25;
        }
        else if(chosen.equals("Entr Open"))
        {
            combo10 = 3;
            digital10 = 6;
        }
        else if(chosen.equals("Entr Close"))
        {
            combo10 = 3;
            digital10 = 7;
        }
        else if(chosen.equals("Exit Open"))
        {
            combo10 = 3;
            digital10 = 8;
        }
        else if(chosen.equals("Exit Close"))
        {
            combo10 = 3;
            digital10 = 9;
        }
        else if(chosen.equals("Chamber Conveyor"))
        {
            combo10 = 4;
            digital10 = 26;
        }
        else if(chosen.equals("ATM Switch"))
        {
            combo10 = 3;
            digital10 = 3;
        }
        else if(chosen.equals("Iso Valve"))
        {
            combo10 = 4;
            digital10 = 31;
        }
        else if(chosen.equals("S7L1"))
        {
            combo10 = 3;
            digital10 = 23;
        }
        else if(chosen.equals("S7L2"))
        {
            combo10 = 3;
            digital10  = 26;
        }
        else if(chosen.equals("S9L1"))
        {
            combo10 = 1;
            digital10 = 4;
        }
        else if(chosen.equals("S9L2"))
        {
            combo10 = 1;
            digital10 = 13;
        }
        else if(chosen.equals("L1 D/S"))
        {
            combo10 = 1;
            digital10 = 5;
        }
        else if(chosen.equals("L2 D/S"))
        {
            combo10 = 1;
            digital10 = 14;
        }
        else if(chosen.equals("Green Light"))
        {
            combo10 = 2;
            digital10 = 27;
        }

        else
            combo10 = -1;
    }
    //</editor-fold>

    @FXML
    private TextField errorBox;



    @FXML
    private Button loadButton;

    @FXML
    private Button debug;


    @FXML
    private TextField enterStartTime;

    @FXML
    private TextField enterEndTime;

    @FXML
    private LineChart lineGraph;



    //Called when Load Graph Button clicked
    @FXML
    void loadGraph(ActionEvent event) throws FileNotFoundException, ParseException
    {
        timeStringToIndex();                            //Run timeStringToIndex() to make a FileParsing object and calculate times

        lineGraph.getData().clear();                    //Clear data on graph for reusability
        if(startTime.length() != 8)
        {
            errorBox.setText("Start Time in Incorrect Format");
        }
        else if(endTime.length() != 8)
        {
            errorBox.setText("End Time in Incorrect Format");
        }
        else if(hhmmssToSeconds(startTime) > hhmmssToSeconds(endTime))
        {
            errorBox.setText("Start Time cannot be greater than End Time");
        }
        else {
            errorBox.setText("");

            ArrayList<int[][]> methods = new ArrayList<int[][]>(); //Store all 8 2D binary arrays into a list for later use

            methods.add(parse.getNode1InputsArr());
            methods.add(parse.getNode1OutputsArr());

            methods.add(parse.getNode2InputsArr());
            methods.add(parse.getNode2OutputsArr());

            methods.add(parse.getNode3InputsArr());
            methods.add(parse.getNode3OutputsArr());

            methods.add(parse.getNode4InputsArr());
            methods.add(parse.getNode4OutputsArr());

            if (combo1 != -1 && digital1 != -1)  //Check that the first combo box is actually selected by user
            {
                XYChart.Series<String, Number> series1 = new XYChart.Series<String, Number>();  //Declare a new series to be graphed
                for (int i = startIndex; i < endIndex - 1; i++) //Data will be added from the csv file from start time to end time
                {
                    //Graphs a time in HH:MM:SS format on X-Axis and graph necessary bit on Y-Axis (add 2 for each subsequent value to avoid overlap)
                    series1.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo1 - 1)[i][digital1 - 1]));
                    //^ 1 is subtracted from combo1 and digital1 for proper indexing
                }
                lineGraph.getData().add(series1);
            }

            if (combo2 != -1 && digital2 != -1) //Repeat same process as combo1 for all other combo boxes
            {
                XYChart.Series<String, Number> series2 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series2.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo2 - 1)[i][digital2 - 1] + 2));
                }
                lineGraph.getData().add(series2);
            }

            if (combo3 != -1 && digital3 != -1) {
                XYChart.Series<String, Number> series3 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series3.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo3 - 1)[i][digital3 - 1] + 4));
                }
                lineGraph.getData().add(series3);
            }
            if (combo4 != -1 && digital4 != -1) {
                XYChart.Series<String, Number> series4 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series4.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo4 - 1)[i][digital4 - 1] + 6));
                }
                lineGraph.getData().add(series4);
            }

            if (combo5 != -1 && digital5 != -1) {
                XYChart.Series<String, Number> series5 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series5.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo5 - 1)[i][digital5 - 1] + 8));
                }
                lineGraph.getData().add(series5);
            }

            if (combo6 != -1 && digital6 != -1) {
                XYChart.Series<String, Number> series6 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series6.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo6 - 1)[i][digital6 - 1] + 10));
                }
                lineGraph.getData().add(series6);
            }

            if (combo7 != -1 && digital7 != -1) {
                XYChart.Series<String, Number> series7 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series7.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo7 - 1)[i][digital7 - 1] + 12));
                }
                lineGraph.getData().add(series7);
            }

            if (combo8 != -1 && digital8 != -1) {
                XYChart.Series<String, Number> series8 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series8.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo8 - 1)[i][digital8 - 1] + 14));
                }
                lineGraph.getData().add(series8);
            }

            if (combo9 != -1 && digital9 != -1) {
                XYChart.Series<String, Number> series9 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series9.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo9 - 1)[i][digital9 - 1] + 16));
                }
                lineGraph.getData().add(series9);
            }

            if (combo10 != -1 && digital10 != -1) {
                XYChart.Series<String, Number> series10 = new XYChart.Series<String, Number>();
                for (int i = startIndex; i < endIndex - 1; i++) {
                    series10.getData().add(new XYChart.Data<String, Number>(myTimes.get(i), methods.get(combo10 - 1)[i][digital10 - 1] + 18));
                }
                lineGraph.getData().add(series10);
            }
        }

    }

    public void timeStringToIndex() throws FileNotFoundException
    {
        //Converts time entry (HH:MM:SS) to String
        startTime = enterStartTime.getText();
        endTime = enterEndTime.getText();
        //Creates new FileParsing object to convert csv file to binary arrays
        if(csvFile == null)
        {
            errorBox.setText("Select File Before Graphing");
        }
        parse = new FileParsing(csvFile);
        //Clears previous list of times
        myTimes.clear();

        ArrayList<String> unformattedTime = parse.getTime();
        //unformatted time contains day, month, year as well (unnecessary)
        for(String unformatted: unformattedTime)
        {
            String formatted = unformatted.substring(unformatted.length()-8);       //Last 8 characters of unformatted time are HH:MM:SS
            myTimes.add(formatted);
        }
        //Searches for start time
        for(int a = 0; a < myTimes.size(); a++)
        {
            if(myTimes.get(a).indexOf(startTime) != -1)
            {
                startIndex = a;
            }
        }
        //Searches for End Time
        for(int b = 0; b < myTimes.size(); b++)
        {
            if(myTimes.get(b).indexOf(endTime) != -1)
            {
                endIndex = b;
            }
        }
    }



        @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
            fileChooser.setInitialDirectory(new File("C:\\"));
            //Initializes list for each combo box
            ObservableList<String> nodes = FXCollections.observableArrayList("L1 Admit", "L2 Admit", "S1L1", "S1L2", "S3L1",
                    "S3L2", "Entr Open", "Entr Close", "Exit Open", "Exit Close", "Chamber Conveyor", "ATM Switch", "Iso Valve",
                    "S7L1", "S7L2", "S9L1", "S9L2", "L1 D/S", "L2 D/S", "Green Light", "Choose Node");

            comb.setItems(nodes);
            comb2.setItems(nodes);
            comb3.setItems(nodes);
            comb4.setItems(nodes);
            comb5.setItems(nodes);
            comb6.setItems(nodes);
            comb7.setItems(nodes);
            comb8.setItems(nodes);
            comb9.setItems(nodes);
            comb10.setItems(nodes);

    }

    /*
        Converts a string in "HH:MM:SS" format into seconds from an arbitrary but constant reference point
     */
    public long hhmmssToSeconds(String hhmmss) throws ParseException {
        DateFormat dateFormat = new SimpleDateFormat("HH:mm:ss");
        Date reference = dateFormat.parse("00:00:00");
        Date date = dateFormat.parse(hhmmss);
        long seconds = (date.getTime() - reference.getTime()) / 1000L;
        return seconds;
    }
}
