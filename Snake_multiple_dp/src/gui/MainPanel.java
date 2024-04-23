package gui;

import game.Field;
import game.Grid;
import game.Snake;
import snake_movement.SnakeController;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import java.util.List;

public class MainPanel extends JPanel {

    private Graphics graph;
    private BufferedImage bgImage;
    private JButton stopButton;
    public MainPanel()
    {
        try {
            bgImage = ImageIO.read(new File("background.jpg"));
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void drawRect(int coorX,int coorY, Color color) {
        graph.setColor(color);
        graph.fill3DRect(coorX, coorY, 25, 25,true);
    }

    @Override
    public void paint(Graphics graphics) {
        super.paint(graphics);

        this.graph = graphics;

        graph.drawImage(bgImage, 0, 0, this);

        List<Field> snakeList = Snake.getSnakeFields();
        Field head = snakeList.get(0);
        drawRect(head.getX() * 25, head.getY() * 25, Color.RED);

        Field snakeField;
        for (int i = 1; i < snakeList.size(); i++) {
            snakeField = snakeList.get(i);
            drawRect(snakeField.getX() * 25, snakeField.getY() * 25, Color.GREEN);

        }
        Field fruitPos = Grid.getFruitPosition();
        graph.drawImage(Grid.getApple().getImage(), 25 * fruitPos.getX(), 25 * fruitPos.getY(), null);

    }

}

