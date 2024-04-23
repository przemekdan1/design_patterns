package snake_movement;

import game.Snake;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class KeyboardHandler extends KeyAdapter {
    private boolean isLocked = false;
    private static KeyboardHandler instance = new KeyboardHandler();

    private KeyboardHandler(){
        ;
    }

    public static KeyboardHandler getInstance(){
        return instance;
    }

    public void keyPressed(KeyEvent keyEvent) {
        int pressedKeyCode = keyEvent.getKeyCode();
        MoveDirection directionToMoveTheSnake = MoveDirection.getMoveDirectionByPressedKeyCode(pressedKeyCode);
        if (directionToMoveTheSnake != null && ! isLocked) {

            switch (directionToMoveTheSnake) {
                case UP:
                    SnakeController.changeState(Snake.getCurrentState().goUp());
                    break;
                case DOWN:
                    SnakeController.changeState(Snake.getCurrentState().goDown());
                    break;
                case LEFT:
                    SnakeController.changeState(Snake.getCurrentState().goLeft());
                    break;
                case RIGHT:
                    SnakeController.changeState(Snake.getCurrentState().goRight());
                    break;
            }

            isLocked = true;
        }
    }
    public void unlock(){
        this.isLocked = false;
    }
}

