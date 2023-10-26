use std::io;

fn main() {
    let (num1, num2) = input_values();
    println!("{}", solution(num1, num2));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (i32,i32) {
    let values: Vec<i32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(num1: i32, num2: i32) -> i32 {
    let mut sum: i32 = 0;
    for num in num1..=num2 {
        sum += (num*num) as i32;
    }
    sum
}