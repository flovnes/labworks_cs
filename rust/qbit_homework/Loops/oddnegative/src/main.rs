use std::io;

fn main() {
    let (num1, num2) = input_values();
    solution(num1, num2);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (f32,f32) {
    let values: Vec<f32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(num1: f32, num2: f32) {
    for num in num1..=num2 {
        print!("{}", (-1_f32).pow(num-1)*(3*num-1)); 
    }
}