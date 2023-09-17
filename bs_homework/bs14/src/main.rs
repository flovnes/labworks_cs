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

fn input_values() -> (f32,f32,f32) {
    let values: Vec<f32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1], values[2])
}

fn solution(values: (f32,f32,f32)) -> f32 {
    let (hour, min, sec) = values;
    let sum = hour*30.+min/2.+sec/120.;
    if sum < 360. {sum} else {(360.-sum).abs()}
}