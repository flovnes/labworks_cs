use std::io;

fn main() {
    let values = input_values();
    let d_values = input_values();
    let (hour, min, sec) = solution(values, d_values);
    println!("{} {} {}", hour, min, sec);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (i32,i32,i32) {
    let values: Vec<i32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1], values[2])
}

fn solution(before: (i32, i32, i32), after: (i32, i32, i32)) -> (i32, i32, i32) {
    let (hour, min, sec) = before;
    let (dhour, dmin, dsec) = after;

    let total_before = hour*3600 + min*60 + sec;
    let total_after = dhour*3600 + dmin*60 + dsec;

    let seconds_total = (total_before-total_after).abs();
    let minutes_total = seconds_total/60;
    
    (minutes_total/60, minutes_total%60, seconds_total%60)
}