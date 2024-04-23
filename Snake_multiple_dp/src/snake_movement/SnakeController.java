package snake_movement;

import game.*;
import snake_state.SnakeState;

import java.util.List;
import java.util.Timer;

public class SnakeController {
    public static IGameSpeed gamespeed;
    public static Timer threadID;

    public static void moveSnakeAndUpdateGameState() {
        doMoveByUpdatingSnakeFields();

        if (Snake.isDead()) {
            System.out.println("Game Over");
            GameOver.reset();
        } else if (Grid.isFruitEaten()) {
            Score scoreObject = Score.getInstance();
            scoreObject.updateScore();
            scoreObject.showScore();
            SnakeController.growSnake();


            switch (Grid.getApple()) {
                case CLASSIC:
                    gamespeed = new SpeedSlow();
                    break;
                case MEDIUMSPEED:
                    gamespeed = new SpeedMedium();
                    break;
                case FASTSPEED:
                    gamespeed = new SpeedFast();
                    break;
            }
            // Start a new thread
            threadID = gamespeed.restartGame(threadID);

            Grid.spawnFruit();
            Grid.spawnAdditionalApples(2);
        }
    }

    public static void changeState(SnakeState state) {
        SnakeState currentState = Grid.getSnake().getCurrentState();


        if (state == null) {
            return;
        }

        Grid.getSnake().setCurrentState(state);
    }
    public static void stopGame() {
        threadID.cancel();
    }
    public static void doMoveByUpdatingSnakeFields() {
        Snake snake = Grid.getSnake();
        List<Field> snakeBody = snake.getSnakeFields();
        // Save pixel to be removed and remove it (tip of the snakeBody)
        snake.setLastRemovedField(snakeBody.get(snakeBody.size() - 1));
        snakeBody.remove(snakeBody.size() - 1);

        // Add new pixel in specified presentDirection
        Snake.getCurrentState().add();
        KeyboardHandler.getInstance().unlock(); //unlocks controller for next move
    }

    public static void growSnake() {
        Snake snake = Grid.getSnake();
        snake.getSnakeFields().add(snake.getSnakeFields().size(), snake.getLastRemovedField());
    }
}
