use std::io;

fn main() {
    let team_left = input_values();
    let team_right = input_values();

    solution(team_left, team_right);
}

struct Team {
    name: String,
    score: String
}

fn input_values() -> Team {
    let mut team = Team {name: String::from(""), score: String::from("")};
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    team.name = String::from(input_line.trim().clone());
    input_line.clear();
    let _ = io::stdin().read_line(&mut input_line);
    team.score = String::from(input_line.trim().clone());
    team
}

fn solution(team_l: Team, team_r: Team) {
    let mut spaces: usize = 12 - team_l.name.len();
    let mut spaces_str = String::new();
    let mut spaces_scr = String::new();
    while spaces > 0 {
        spaces_str = format!("{spaces_str}{}", " ");
        spaces -= 1;
    }
    spaces = (12 - team_l.score.len()) as usize;
    while spaces > 0 {
        spaces_scr = format!("{spaces_scr}{}", " ");
        spaces -= 1;
    }

    println!("{}", format!("{0} : {1}", format!("{spaces_str}{0}", team_l.name), team_r.name));
    println!("{}", format!("{0} : {1}", format!("{spaces_scr}{0}", team_l.score), team_r.score));
}