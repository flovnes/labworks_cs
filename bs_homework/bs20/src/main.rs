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

fn input_values() -> (u8,u8,u8) {
    let values: Vec<u8> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1], values[2])
}


fn solution(values: (u8,u8,u8), delta: (u8,u8,u8)) -> (u8,u8,u8) {
    let (mut hour, mut min, mut sec) = values;
    let (dhour, dmin, dsec) = delta;

    sec += dsec;
    (hour, min, sec) = check((hour, min, sec));
    min += dmin;
    (hour, min, sec) = check((hour, min, sec));
    hour += dhour;
    (hour, min, sec) = check((hour, min, sec));
    (hour, min, sec)
}

fn check(values: (u8,u8,u8)) -> (u8,u8,u8) {
    let (mut hour, mut min, mut sec) = values;
    if sec >= 60 {
        sec -= 60;
        min += 1;
    }
    if min >= 60 {
        min -= 60;
        hour += 1;
    }
    if hour >= 24 {
        hour -= 24;
    }
    (hour, min, sec)
}