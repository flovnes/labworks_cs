use std::io;

fn main() {
    solution();
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() {
    let mut direction: i16 = 1;
    let (mut x, mut y) = (0,0);
    'a: loop 
    {
        match input_line().trim() {
            "R" => {
                direction+=1;
            },
            "L" => {
                direction = (direction-1).abs();
            },
            "F" => {
                walk(&direction, &mut x, &mut y);
            },
            _ => break 'a
        }
    }
    println!("{0} {1}", x, y);
}

fn walk(direction: &i16, x: &mut  i16, y: &mut i16) {
    match direction%4 { 
        1 => {
            *y+=1;
        },
        2 => {
            *x+=1;
        },
        3 => {
            *y-=1;
        },
        0 => {
            *x-=1;
        },
        _ => (),
    }
}