use std::io;

fn main() {
    let (pages, pages_morning) = input_values();

    println!("{}",solution(pages, pages_morning));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (f32, f32) {
    let mut values: Vec<f32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    values.append(&mut input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect());
    (values[0], values[1])
}

fn solution(total: f32, morning: f32) -> u32 { 
    let pages_per_day = morning + morning/3.;
    (total / pages_per_day).ceil() as u32
}