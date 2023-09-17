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

fn input_values() -> (u64,u64) {
    let values: Vec<u64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(values: (u64,u64)) -> u64 {
    let (marbles, icicles) = values;
    ((marbles as f64/3.).ceil() + (icicles as f64/4.).ceil()) as u64
}