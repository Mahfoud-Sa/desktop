# Simple Snake Game in Python 3 for Beginners
# mohammed

import turtle
import time
import random
import winsound

delay = 0.1

# Score
score = 0
high_score = 0
score_P2 = 0
high_score_P2 = 0

# Set up the screen
wn = turtle.Screen()
wn.title("GAME MAB2000 snake test")
wn.bgcolor("black")
wn.setup(width=600, height=600)
wn.tracer(0)  # Turns off the screen updates

# Snake head
head = turtle.Turtle()
head.speed(0)
head.shape("square")
head.color("red")
head.penup()
head.goto(0, 0)
head.direction = "stop"

# P2 snake head
head_P2 = turtle.Turtle()
head_P2.speed(0)
head_P2.shape("square")
head_P2.color("green")
head_P2.penup()
head_P2.goto(100, 0)
head_P2.direction = "stop"

# Snake food
food = turtle.Turtle()
food.speed(0)
food.shape("circle")
food.color("blue")
food.penup()
food.goto(0, 100)

food2 = turtle.Turtle()
food2.speed(0)
food2.shape("circle")
food2.color("blue")
food2.penup()
food2.goto(100,100)

segments = []
segments2 = []

# Pen
pen = turtle.Turtle()
pen.speed(0)
pen.shape("square")
pen.color("red")
pen.penup()
pen.hideturtle()
pen.goto(0, 260)
pen.write("Score: 0  High Score: 0", align="center", font=("Courier", 24, "normal"))

#pen P2
pen_P2 = turtle.Turtle()
pen_P2.speed(0)
pen_P2.shape("square")
pen_P2.color("green")
pen_P2.penup()
pen_P2.hideturtle()
pen_P2.goto(0, 220)
pen_P2.write("Score P2: 0  High Score P2: 0", align="center", font=("Courier", 24, "normal"))

# Functions
def go_up():
    if head.direction != "down":
        head.direction = "up"


def go_down():
    if head.direction != "up":
        head.direction = "down"


def go_left():
    if head.direction != "right":
        head.direction = "left"


def go_right():
    if head.direction != "left":
        head.direction = "right"


def move():
    if head.direction == "up" :
        y = head.ycor()
        head.sety(y + 20)

    if head.direction == "down":
        y = head.ycor()
        head.sety(y - 20)

    if head.direction == "left":
        x = head.xcor()
        head.setx(x - 20)

    if head.direction == "right":
        x = head.xcor()
        head.setx(x + 20)

def go_up2():
    if head_P2.direction != "down":
        head_P2.direction = "up"


def go_down2():
    if head_P2.direction != "up":
        head_P2.direction = "down"


def go_left2():
    if head_P2.direction != "right":
        head_P2.direction = "left"


def go_right2():
    if head_P2.direction != "left":
        head_P2.direction = "right"


def move2():
    if head_P2.direction == "up" :
        y = head_P2.ycor()
        head_P2.sety(y + 20)

    if head_P2.direction == "down":
        y = head_P2.ycor()
        head_P2.sety(y - 20)

    if head_P2.direction == "left":
        x = head_P2.xcor()
        head_P2.setx(x - 20)

    if head_P2.direction == "right":
        x = head_P2.xcor()
        head_P2.setx(x + 20)


# Keyboard bindings for P1 and P2
wn.listen()
wn.onkeypress(go_up, "w")
wn.onkeypress(go_down, "s")
wn.onkeypress(go_left, "a")
wn.onkeypress(go_right, "d")
wn.onkeypress(go_up2, "i")
wn.onkeypress(go_down2, "k")
wn.onkeypress(go_left2, "j")
wn.onkeypress(go_right2, "l")

# Main game loop
while True:
    wn.update()
    # Check for a collision with the border
    if head.xcor() > 290 or head.xcor() < -290 or head.ycor() > 290 or head.ycor() < -290:
        time.sleep(0)
        head.goto(0, 0)
        head.direction = "stop"
        # Hide the segments
        for segment in segments:
            segment.goto(1000, 1000)
        # Clear the segments list
        segments.clear()
        # Reset the score
        score = 0
        # Reset the delay
        delay = 0.1
        pen.clear()
        pen.write("Score: {}  High Score: {}".format(score, high_score), align="center", font=("Courier", 24, "normal"))

    if head_P2.xcor() > 290 or head_P2.xcor() < -290 or head_P2.ycor() > 290 or head_P2.ycor() < -290:
        time.sleep(0)
        head_P2.goto(100, 0)
        head_P2.direction = "stop"

        # Hide the segments
        for segment10 in segments2:
            segment10.goto(1000, 1000)
        # Clear the segments list
        segments2.clear()
        # Reset the score
        score_P2=0
        # Reset the delay
        delay = 0.1

        pen_P2.clear()
        pen_P2.write("Score P2: {}  High Score P2: {}".format(score_P2, high_score_P2), align="center", font=("Courier", 24, "normal"))

    # Check for a collision with the food
    if head.distance(food) < 20:
        # Move the food to a random spot
        x = random.randint(-290, 290)
        y = random.randint(-290, 290)
        food.goto(x, y)
        # Add a segment
        new_segment = turtle.Turtle()
        new_segment.speed(0)
        new_segment.shape("circle")
        new_segment.color("grey")
        new_segment.penup()
        segments.append(new_segment)
        # Shorten the delay
        delay -= 0.001
        # Increase the score
        score += 10
        if score > high_score:
            high_score = score
        pen.clear()
        pen.write("Score: {}  High Score: {}".format(score, high_score), align="center", font=("Courier", 24, "normal"))

    if head.distance(food2) < 20:
        # Move the food to a random spot
        x = random.randint(-290, 290)
        y = random.randint(-290, 290)
        food2.goto(x, y)
        # Add a segment
        new_segment = turtle.Turtle()
        new_segment.speed(0)
        new_segment.shape("circle")
        new_segment.color("grey")
        new_segment.penup()
        segments.append(new_segment)
        # Shorten the delay
        delay -= 0.001
        # Increase the score
        score += 10
        if score > high_score:
            high_score = score
        pen.clear()
        pen.write("Score: {}  High Score: {}".format(score, high_score), align="center", font=("Courier", 24, "normal"))

    if head_P2.distance(food) < 20:
        x = random.randint(-290, 290)
        y = random.randint(-290, 290)
        food.goto(x, y)
        # Add a segment
        new_segment2 = turtle.Turtle()
        new_segment2.speed(0)
        new_segment2.shape("circle")
        new_segment2.color("grey")
        new_segment2.penup()
        segments2.append(new_segment2)
        # Shorten the delay
        delay -= 0.001
        # Increase the score
        score_P2+=10
        if score_P2 > high_score_P2:
            high_score_P2= score_P2
        pen_P2.clear()
        pen_P2.write("Score P2: {}  High Score P2: {}".format(score_P2, high_score_P2), align="center", font=("Courier", 24, "normal"))

    if head_P2.distance(food2) < 20:
        x = random.randint(-290, 290)
        y = random.randint(-290, 290)
        food2.goto(x, y)
        # Add a segment
        new_segment2 = turtle.Turtle()
        new_segment2.speed(0)
        new_segment2.shape("circle")
        new_segment2.color("grey")
        new_segment2.penup()
        segments2.append(new_segment2)
        # Shorten the delay
        delay -= 0.001
        # Increase the score
        score_P2 += 10
        if score_P2 > high_score_P2:
            high_score_P2 = score_P2
        pen_P2.clear()
        pen_P2.write("Score P2: {}  High Score P2: {}".format(score_P2, high_score_P2), align="center",font=("Courier", 24, "normal"))

    # Move the end segments first in reverse order
    for index in range(len(segments) - 1, 0, -1):
        x = segments[index - 1].xcor()
        y = segments[index - 1].ycor()
        segments[index].goto(x, y)

    for index in range(len(segments2) - 1, 0, -1):
        x = segments2[index - 1].xcor()
        y = segments2[index - 1].ycor()
        segments2[index].goto(x, y)

    # Move segment 0 to where the head is
    if len(segments) > 0:
        x = head.xcor()
        y = head.ycor()
        segments[0].goto(x, y)
    if len(segments2) > 0:
        x = head_P2.xcor()
        y = head_P2.ycor()
        segments2[0].goto(x, y)

    move()
    move2()

    # Check for head collision with the body segments
    for segment in segments:
        if segment.distance(head) < 20:
            time.sleep(1)
            head.goto(0, 0)
            head.direction = "stop"
            # Hide the segments
            for segment in segments:
                segment.goto(1000, 1000)

            # Clear the segments list
            segments.clear()
            # Reset the score
            score = 0
            # Reset the delay
            delay = 0.1
            # Update the score display
            pen.clear()
            pen.write("Score: {}  High Score: {}".format(score, high_score), align="center",
                      font=("Courier", 24, "normal"))

    for segment in segments2:
        if segment.distance(head_P2) < 20:
            time.sleep(1)
            head_P2.goto(0, 0)
            head_P2.direction = "stop"

            # Hide the segments
            for segment in segments2:
                segment.goto(1000, 1000)

            # Clear the segments list
            segments2.clear()

            # Reset the score
            score_P2=0

            # Reset the delay
            delay = 0.1

            # Update the score display
            pen_P2.clear()
            pen_P2.write("Score P2: {}  High Score P2: {}".format(score_P2, high_score_P2), align="center",font=("Courier", 24, "normal"))

    time.sleep(delay)

wn.mainloop()