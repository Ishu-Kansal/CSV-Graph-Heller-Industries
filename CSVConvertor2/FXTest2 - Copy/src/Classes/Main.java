package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Group;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

public class Main extends Application
{



    public static void main(String[] args)
    {
        Application.launch(args);
    }

    @Override
    public void start(Stage stage) throws Exception
    {
        Group root = new Group();


        Parent root2 = FXMLLoader.load(getClass().getResource("Main.fxml"));
        stage.setTitle("Heller Industries Discrete Oven Log Software");
        Scene scene = new Scene(root2);
        Image icon = new Image("HIcon.png");
        String style = this.getClass().getResource("/styling.css").toExternalForm();
        scene.getStylesheets().add(style);
        stage.getIcons().add(icon);
        stage.setScene(scene);
        stage.setMaximized(true);
        stage.show();
    }
}
