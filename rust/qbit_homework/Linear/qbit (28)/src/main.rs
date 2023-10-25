use std::io;

fn main() {
    let (cantimeters, milimeters) = input_values();

    println!("{}",solution(cantimeters, milimeters));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (f32, f32) {
    let values: Vec<f32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    values.append(&mut input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect());
    (values[0], values[1])
}

fn solution(cm: f32, mm: f32) -> u32 { 
    (cm*10.0/mm).ceil() as u32
}