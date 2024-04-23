package game;

import java.util.Random;

public class Grid implements IRestart {

    private static Grid instance = new Grid();

    private static Field fruitPosition;
    private static Apple apple;
    private static Snake snake;

    private Grid(){
        snake = new Snake();
        apple = Apple.FASTSPEED;
        spawnFruit();
        GameOver.addRestartable(this);
    }

    public static Grid getInstance() {
        return instance;
    }

    public static Field getFruitPosition() {
        return fruitPosition;
    }

    public static Apple getApple(){
        return apple;
    }

    public static void reGenerateApple(){
        apple = apple.generateNewApple();
    }

    public static boolean isFruitEaten(){
        return snake.getHead().equals(fruitPosition);
    }

    public static void spawnFruit(){

        fruitPosition = new Field(new Random().nextInt(40 - 10),
                new Random().nextInt(40 - 10));

        while ( Snake.getSnakeFields().contains(fruitPosition) ) {
            fruitPosition = new Field(new Random().nextInt(40 - 10),
                    new Random().nextInt(40 - 10));
        }

        reGenerateApple();
    }

    public static void spawnAdditionalApples(int numberOfApples) {
        for (int i = 0; i < numberOfApples; i++) {
            spawnFruit();
        }
    }

    public void restart() {
        spawnFruit();
    }

    public static Snake getSnake() {
        return snake;
    }

}
