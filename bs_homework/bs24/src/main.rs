use std::io;

fn main() {
    let (day_year, day_week) = input_values();

    println!("{}", solution(day_year, day_week));
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u64, u64){
    let values: Vec<u64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(day_year: u64, day_week: u64) -> u64 { 
    if (day_year + day_week-1)% 7 == 0 {
        7
    } else {
        (day_year + day_week-1)% 7
    }
}