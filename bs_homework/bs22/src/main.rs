use std::io;

fn main() {
    let (hour, min, sec) = solution(input_values());
    println!("{}:{}:{}", hour, min, sec);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> u64 {
    input_line().trim().parse().unwrap()
}

fn solution(mut seconds_total: u64) -> (String, String, String) {
    seconds_total %= 86400;
    let minutes_total = seconds_total/60;

    let mut hour = (minutes_total/60).to_string();
    let mut mins = (minutes_total%60).to_string();
    let mut secs = (seconds_total%60).to_string();

    if (minutes_total / 60) < 10 {hour = format!("0{}", hour);}
    if (minutes_total % 60) < 10 {mins = format!("0{}", mins);}
    if (seconds_total % 60) < 10 {secs = format!("0{}", secs);}

    (hour, mins, secs)
}
