use std::io;

fn main() {
    let values = input_values();
    println!("{}", solution(values));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u32,u32,u32) {
    (input_line().trim().parse().unwrap(), input_line().trim().parse().unwrap(), input_line().trim().parse().unwrap())
}

fn solution(values: (u32,u32,u32)) -> u32 {
    let (height, up, down) = values;
    let mut current_height = 0;
    let mut current_day = 0;
    loop {
        current_height += up;
        current_day += 1;
        if current_height < height {
            current_height -= down;
        } else {
            return current_day;
        }
    }
}