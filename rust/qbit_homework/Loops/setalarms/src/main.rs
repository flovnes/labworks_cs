use std::io;

fn main() {
    solution(input_values());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u16,u16) {
    let values: Vec<u16> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(time: (u16, u16)) {
    let num = input_line().trim().parse().unwrap();
    let (hour, minute) = time;
    let time_total = hour*60 + minute;
    for i in 0..num {
        println!("{0:02}:{1:02}", (time_total + 5*i)/60%24, (time_total + 5*i)%60)
    }
}