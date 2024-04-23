package game;

import javax.imageio.ImageIO;
import java.awt.*;
import java.io.File;
import java.io.IOException;
import java.util.Random;


public enum Apple{

    CLASSIC, MEDIUMSPEED,FASTSPEED ;

    private Image classicImage, mediumImage, fastImage;


    Apple(){

        classicImage = null;
        try {
            classicImage = ImageIO.read(new File("apple.png"));
        } catch (IOException e) {
            e.printStackTrace();
        }

        mediumImage = null;
        try {
            mediumImage = ImageIO.read(new File("green_apple.png"));
        } catch (IOException e) {
            e.printStackTrace();
        }

        fastImage = null;
        try {
            fastImage = ImageIO.read(new File("golden_apple.png"));
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    public Apple generateNewApple() {

        Random rand = new Random();

        int  n = rand.nextInt(3);
        switch (n) {
            case 0:   return FASTSPEED;
            case 1:   return MEDIUMSPEED;
            default:  return CLASSIC;
        }
    }

    public Image getImage(){

        if ( this.equals( Apple.CLASSIC ) ) return classicImage;
        if ( this.equals( Apple.MEDIUMSPEED ) ) return mediumImage;
        if ( this.equals( Apple.FASTSPEED ) ) return fastImage;

        return classicImage;
    }


}
